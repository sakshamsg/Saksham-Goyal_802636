import { Component } from '@angular/core';
import { Route } from '@angular/compiler/src/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  router:any;
  title = 'mean';

  settok(){
    var set='';
    set=localStorage.getItem('token');
    if(set==null)
    {
      return 0;
    }
    else{
      return 1;
    }
  }
    logout(){
      localStorage.removeItem('token');
      this.router.navigate(['ul']);
    }
    // dash(){
    //   var d='';
    //   d=localStorage.getItem('')
    // }
}
