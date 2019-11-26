import { Component, OnInit } from '@angular/core';
import { Mentor } from '../_Models/mentor';
import { MentorService } from '../_Services/mentor.service';

@Component({
  selector: 'app-admin-mentor',
  templateUrl: './admin-mentor.component.html',
  styleUrls: ['./admin-mentor.component.css']
})
export class AdminMentorComponent implements OnInit {
  item:Mentor;
  list:Mentor[];
  msg:string;

  constructor(private _service: MentorService) {
    this.item=new Mentor();
    this._service.GetAll().subscribe(k=>
      {
        this.list=k;
        console.log(k);
      })
   }

  ngOnInit() {
  }

  public Update(){
    this._service.Update(this.item).subscribe(k=>this.msg)
  }

  public Delete(id:string){
    console.log(id);
    alert(id);
    this._service.Delete(id).subscribe(k=>k=this.msg)
  }


}
