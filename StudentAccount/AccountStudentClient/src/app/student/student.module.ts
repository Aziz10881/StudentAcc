import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { StudentListComponent } from './student-list/student-list.component';
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'list', component: StudentListComponent }
    ])
  ],
  declarations: [
    StudentListComponent
  ]
})
export class studentModule { }
