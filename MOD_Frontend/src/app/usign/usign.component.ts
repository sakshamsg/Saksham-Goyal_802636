import { Component, OnInit } from '@angular/core';
import { StudentService } from '../_Services/student.service';
import { Student } from '../_Models/student';
import { NgForm, FormGroup, Validators, FormBuilder } from '@angular/forms';
@Component({
  selector: 'app-usign',
  templateUrl: './usign.component.html',
  styleUrls: ['./usign.component.css'],
})
export class UsignComponent implements OnInit {
  item:Student;
  //list:Empclass[];
  msg:string;
  // registerForm: FormGroup;
  // submitted=false;
  
  constructor(private _service: StudentService) { 
    this.item=new Student();
    this.item.studentId="U12239";

  }

  // onSubmit(){
  //     this.submitted = true;
  //     if(this.registerForm.invalid){
  //       return;
  //     }
  //       else{
  //           this.SRegister();
  //       }
      
  //     }

  ngOnInit() {
    // this.registerForm=this.formBuilder.group({
    //   fullName: ['',[Validators.required]],
    //   phone: ['',[Validators.required]],
    //   email: ['',[Validators.required, Validators.email]],
    //   password: ['',[Validators.required, Validators.minLength(6)]]
    // });
  }

  public SRegister(){
    this._service.SRegister(this.item).subscribe(k=>this.msg=k)
    console.log(this.item);
  }
  }

 
