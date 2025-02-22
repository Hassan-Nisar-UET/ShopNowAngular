import { Component } from '@angular/core';

@Component({
  selector: 'app-shops',
  templateUrl: './shops.component.html',
  styleUrl: './shops.component.css'
})
export class ShopsComponent {
  dataSource = [
    { id: 1, name: "John Doe", description: "Software Engineer", address: "123 Main St, NY", country: "USA", type: "Employee", phone: "+1 234 567 890", gmail: "johndoe@gmail.com" },
    { id: 2, name: "Jane Smith", description: "Graphic Designer", address: "456 Elm St, LA", country: "USA", type: "Freelancer", phone: "+1 987 654 321", gmail: "janesmith@gmail.com" },
    { id: 3, name: "Ali Khan", description: "Business Analyst", address: "789 Oak St, TX", country: "Pakistan", type: "Consultant", phone: "+92 300 1234567", gmail: "alikhan@gmail.com" },
    { id: 4, name: "Emily Brown", description: "Marketing Manager", address: "101 Pine St, CA", country: "Canada", type: "Manager", phone: "+1 456 789 012", gmail: "emilybrown@gmail.com" }
  ];

  visible: boolean = false;
  // Pagination properties
  pageSize = 5;
  totalRecords = this.dataSource.length;
  pageSizes = [5, 10, 20];
faPencilAlt: any;

  onPageChange(event: any) {
    console.log('Page changed', event);
  }

  
  history(id: number) {
    console.log('View History', id);
  }

  dataUsage(id: number) {
    console.log('Data Usage [GDPR]', id);
 
  }
  editRecord(id: number) {
    console.log("Edit record:", id);
  }

  deleteRecord(id: number) {
    this.dataSource = this.dataSource.filter(item => item.id !== id);
  }

  

  showDialog() {
      this.visible = true;
  }
}
