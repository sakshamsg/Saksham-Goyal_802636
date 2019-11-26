import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/Http';
import { Observable } from 'rxjs';
import { Mentor } from '../_Models/mentor';

@Injectable({
  providedIn: 'root'
})
export class MentorService {
  path: string='http://localhost:4330/api/Mentor';

  constructor(private _client: HttpClient) { }
  public MRegister(item:Mentor): Observable<string>
  {
    return this._client.post<string>(this.path+'/mentoradd',item);
  }

  public GetAll(): Observable<Mentor[]>
  {
    return this._client.get<Mentor[]>(this.path+"/MentorGetAll");
  }
  public Update(item:Mentor)
  {
    return this._client.put(this.path+"/MentorUpdate",item);
  }

  public Delete(id:string)
  {
    return this._client.delete(this.path+"/MentorDelete/"+id);
  }
}
