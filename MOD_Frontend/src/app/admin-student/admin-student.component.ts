import { Component, OnInit } from '@angular/core';
import { StudentService } from '../_Services/student.service';
import { Student } from '../_Models/student';

@Component({
  selector: 'app-admin-student',
  templateUrl: './admin-student.component.html',
  styleUrls: ['./admin-student.component.css']
})
export class AdminStudentComponent implements OnInit {
  item:Student;
  list:Student[];
  msg:string;

  constructor(private _service: StudentService) {
    this.item=new Student();
    this._service.GetAll().subscribe(k=>
      {
        this.list=k;
        console.log(k);
      })
   }

  ngOnInit() {
  }
  public Delete(id:string){
    console.log(id);
    alert(id);
    this._service.Delete(id).subscribe(k=>k=this.msg)
  }

}
