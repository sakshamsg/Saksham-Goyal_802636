import { Component, OnInit } from '@angular/core';
import { Technology } from '../_Models/technology';
import { TechnologyService } from '../_Services/technology.service';

@Component({
  selector: 'app-admintech',
  templateUrl: './admintech.component.html',
  styleUrls: ['./admintech.component.css']
})
export class AdmintechComponent implements OnInit {
  item:Technology;
  list:Technology[];
  msg:string;

  constructor(private _service: TechnologyService) {
    this.item=new Technology();
    this._service.GetAll().subscribe(k=>
      {
        this.list=k;
        console.log(k);
      })
   }

  ngOnInit() {
  }
  public Delete(id:number){
    console.log(id);
    alert(id);
    this._service.Delete(id).subscribe(k=>k=this.msg)
  }

}
