import { Component, OnInit } from '@angular/core';
import { TrainingService } from '../_Services/training.service';
import { Training } from '../_Models/training';

@Component({
  selector: 'app-comptr',
  templateUrl: './comptr.component.html',
  styleUrls: ['./comptr.component.css']
})
export class ComptrComponent implements OnInit {
  item:Training;
  list:Training[];
  msg:string;

  constructor(private _service: TrainingService) {
    this.item=new Training();
    this._service.GetAll('Completed').subscribe(k=>
      {
        this.list=k;
        console.log(this.list);
      })
   }

  ngOnInit() {
  }

}
