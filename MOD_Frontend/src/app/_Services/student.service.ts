import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from '../_Models/student';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  path: string='http://localhost:4330/api/Student';

  constructor(private _client: HttpClient) { }
  public SRegister(item:Student): Observable<string>
  {
    return this._client.post<string>(this.path+'/StudentAdd',item);
  }

  public GetAll(): Observable<Student[]>
  {
    return this._client.get<Student[]>(this.path+"/StudentGetAll");
  }

  public Delete(id:string)
  {
    return this._client.delete(this.path+"/StudentDelete/"+id);
  }
}
