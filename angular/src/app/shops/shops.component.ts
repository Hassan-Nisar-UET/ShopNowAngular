import { Component } from '@angular/core';

@Component({
  selector: 'app-shops',
  templateUrl: './shops.component.html',
  styleUrl: './shops.component.css'
})
export class ShopsComponent {
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
faPencilAlt: any;

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
}
