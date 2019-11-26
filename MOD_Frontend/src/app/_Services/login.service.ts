import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  path:string="http://localhost:4341/api/Login"
  constructor(private _client:HttpClient) { }
  public Login(id,pwd):Observable<any>
  {
    return this._client.get<any>(this.path+'/Validate/'+id+'/'+pwd);
 
  }
}
