import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';
import { Mentor } from '../_Models/mentor';
import { MentorService } from '../_Services/mentor.service';

@Component({
  selector: 'app-msign',
  templateUrl: './msign.component.html',
  styleUrls: ['./msign.component.css']
})
export class MsignComponent implements OnInit {
  item:Mentor;
  //list:Empclass[];
  msg:string;

  // registerForm: FormGroup;
  constructor(private _service: MentorService) {
    this.item=new Mentor();
    this.item.mentorId="M12239";
   }

  // onSubmit(){
  //   this.signU = this.userService.postUser(this.fullName,this.email,this.password,this.cno,this.liurl,this.exp)
  //     }

  ngOnInit() {
     }

    public MRegister(){
      this._service.MRegister(this.item).subscribe(k=>this.msg=k)
      console.log(this.item);
    }
  }

  


