import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/Http';
import { Observable } from 'rxjs';
import { Technology } from '../_Models/technology';

@Injectable({
  providedIn: 'root'
})
export class TechnologyService {
  path: string='http://localhost:4338/api/Technology';


  constructor(private _client: HttpClient) { }

  public GetAll(): Observable<Technology[]>
  {
    return this._client.get<Technology[]>(this.path+"/TechGetAll");
  }

  public Delete(id:number)
  {
    return this._client.delete(this.path+"/TechDelete/"+id);
  }
}
