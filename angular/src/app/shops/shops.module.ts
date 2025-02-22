import { makeEnvironmentProviders, NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ShopsRoutingModule } from './shops-routing.module';
import { ShopsComponent } from './shops.component';
import { ButtonModule } from 'primeng/button';
import { MatCardModule } from '@angular/material/card';
// import { ShopsComponent } from './shops/shops.component';
import { TableModule } from 'primeng/table';
import { PaginatorModule } from 'primeng/paginator';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';

import { MenuModule } from 'primeng/menu';
import { CheckboxModule } from 'primeng/checkbox';
import { MatMenuModule } from '@angular/material/menu';
import { faEllipsisV, faPencilAlt, faHistory, faDatabase, faKey, faUserMinus, faTrash } from '@fortawesome/free-solid-svg-icons';

// Material Modules
import { MatButtonModule } from '@angular/material/button';



@NgModule({
    declarations: [ShopsComponent],
    imports: [SharedModule, 
        ShopsRoutingModule,
        DialogModule,
        InputTextModule,
        ButtonModule,
        TableModule,
        PaginatorModule,
        MenuModule,
        CheckboxModule,
        MatMenuModule,
        MatButtonModule,
        MatCardModule],
})
export class ShopsModule {

    dataSource = {
        data: [
          {
            id: 1,
            SurName: 'Smith',
            FirstName: 'John',
            Email: 'john.smith@example.com',
            Company: 'ABC Corp',
            Verfied: true,
            imagePath: 'https://via.placeholder.com/40',
            Position: 'Software Engineer'
          },
          {
            id: 2,
            SurName: 'Doe',
            FirstName: 'Jane',
            Email: 'jane.doe@example.com',
            Company: 'XYZ Ltd',
            Verfied: false,
            imagePath: 'https://via.placeholder.com/40',
            Position: 'Product Manager'
          },
          {
            id: 3,
            SurName: 'Brown',
            FirstName: 'Michael',
            Email: 'michael.brown@example.com',
            Company: 'Tech Innovations',
            Verfied: true,
            imagePath: 'https://via.placeholder.com/40',
            Position: 'UX Designer'
          }
        ]
      };
    
      // Pagination properties
      pageSize = 5;
      totalRecords = this.dataSource.data.length;
      pageSizes = [5, 10, 20];
    
      onPageChange(event: any) {
        console.log('Page changed', event);
      }
    
      editClient(id: number) {
        console.log('Edit Client', id);
      }
    
      history(id: number) {
        console.log('View History', id);
      }
    
      dataUsage(id: number) {
        console.log('Data Usage [GDPR]', id);
      }
    
      deleteClient(id: number) {
        console.log('Delete Client', id);
      }

      faEllipsisV = faEllipsisV;
      faPencilAlt = faPencilAlt;
      faHistory = faHistory;
      faDatabase = faDatabase;
      faKey = faKey;
      faUserMinus = faUserMinus;
      faTrash = faTrash;
    }
