using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.EntityFrameworkCore.Extensions
{
    public static class SqlParameterExtensions
    {
        public static List<SqlParameter> GetParameters<T>(this T input)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            PropertyInfo[] properties = input.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                string parameterName = $"@{property.Name}";

                SqlDbType dbType = GetSqlDbType(property.PropertyType);

                ParameterDirection direction = ParameterDirection.Input;

                object value = property.GetValue(input);

                if (property.Name == "Sorting" && value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                {

                    string[] sort = value.ToString().Split(' ');

                    parameters.Add(new SqlParameter("@SortingCol", DbType.String) { Direction = direction, Value = sort[0] });

                    parameters.Add(new SqlParameter("@SortType", DbType.String) { Direction = direction, Value = sort[1] });

                }
                else if (property.Name == "Keyword")
                {
                    if (string.IsNullOrWhiteSpace(value?.ToString()))
                    {
                        parameters.Add(new SqlParameter(parameterName, dbType) { Direction = direction, Value = DBNull.Value });
                    }
                    else
                    {
                        parameters.Add(new SqlParameter(parameterName, dbType) { Direction = direction, Value = "%" + value.ToString().Trim() + "%" });
                    }
                }
                else if (value == null)
                {
                    parameters.Add(new SqlParameter(parameterName, dbType) { Direction = direction, Value = DBNull.Value });
                }
                else if (IsCollectionType(property.PropertyType))
                {
                    Type elementType = property.PropertyType.GetGenericArguments()[0];
                    string commaSeparatedValues = ConvertCollectionToCommaSeparatedString(value, elementType);
                    parameters.Add(new SqlParameter(parameterName, dbType) { Direction = direction, Value = commaSeparatedValues });
                }
                else
                {
                    parameters.Add(new SqlParameter(parameterName, dbType) { Direction = direction, Value = value });
                }

            }

            return parameters;
        }
        private static SqlDbType GetSqlDbType(Type type)
        {
            SqlDbType dbType = SqlDbType.NVarChar;

            Type underlyingType = Nullable.GetUnderlyingType(type);

            if (underlyingType != null && underlyingType.IsEnum)
            {
                return SqlDbType.Int;
            }

            switch (Type.GetTypeCode(underlyingType ?? type))
            {
                case TypeCode.Boolean:
                    dbType = SqlDbType.Bit;
                    break;
                case TypeCode.Byte:
                    dbType = SqlDbType.TinyInt;
                    break;
                case TypeCode.Int16:
                    dbType = SqlDbType.SmallInt;
                    break;
                case TypeCode.Int32:
                    dbType = SqlDbType.Int;
                    break;
                case TypeCode.Int64:
                    dbType = SqlDbType.BigInt;
                    break;
                case TypeCode.Single:
                    dbType = SqlDbType.Real;
                    break;
                case TypeCode.Double:
                    dbType = SqlDbType.Float;
                    break;
                case TypeCode.Decimal:
                    dbType = SqlDbType.Decimal;
                    break;
                case TypeCode.DateTime:
                    dbType = SqlDbType.DateTime;
                    break;
                case TypeCode.String:
                    dbType = SqlDbType.NVarChar;
                    break;
                case TypeCode.Object:
                    if (underlyingType == typeof(Guid))
                    {
                        dbType = SqlDbType.UniqueIdentifier;
                    }
                    break;
            }

            return dbType;
        }
        private static bool IsCollectionType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
        }
        private static string ConvertCollectionToCommaSeparatedString(object collection, Type elementType)
        {
            if (elementType == typeof(int))
            {
                return string.Join(",", ((IEnumerable<int>)collection));
            }
            else if (elementType == typeof(Guid))
            {
                return string.Join(",", ((IEnumerable<Guid>)collection).Select(g => g.ToString()));
            }
            // Add more conditions for other supported types

            // Default fallback: Convert elements to strings using ToString()
            return string.Join(",", ((IEnumerable)collection).Cast<object>().Select(e => e.ToString()));
        }
    }
}
