import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/_interfaces/student.model';
import { RepositoryService } from './../../shared/services/repository.service';


@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  public students!: Student[];

  constructor(private repository: RepositoryService) { }

  ngOnInit(): void {
    this.GetAllStudents();
  }

  public GetAllStudents = () => {
    let apiAddress: string = "api/student";
    this.repository.getData(apiAddress)
    .subscribe(res => {
      this.students = res as Student[];
    })
  }
}