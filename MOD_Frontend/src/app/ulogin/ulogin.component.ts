import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { LoginService } from '../_Services/login.service';

@Component({
  selector: 'app-ulogin',
  templateUrl: './ulogin.component.html',
  styleUrls: ['./ulogin.component.css']
})
export class UloginComponent implements OnInit {
id;
pwd;
msg:string;

constructor(private http:HttpClient, private _service: LoginService, private router: Router) { }

  ngOnInit() {
  }

  public Login()
  {
    this._service.Login(this.id,this.pwd).subscribe(data=>{
      console.log(data)
      if(data.message=='User')
      {

        console.log("HAHAHAHHAHAHA");
        
        console.log(data.token);
        console.log(data.message);
        localStorage.setItem('token',data.token);
        this.router.navigate(['udsh'],{});
      }
      else if(data.message=='Mentor')
      {
        console.log("safhgasjhfas");
        localStorage.setItem('token',data.token);
        this.router.navigate(['mdsh'],{});
      }
      else if(data.message=='Admin')
      {
        localStorage.setItem('token',data.token);
        this.router.navigate(['addsh'],{});
        console.log(data.token);     
      }

    },
    err=>{
       console.log("subscribe err");
    });
  }
}