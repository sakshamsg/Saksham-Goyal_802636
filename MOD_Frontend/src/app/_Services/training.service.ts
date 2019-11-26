import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Training } from '../_Models/training';
import { HttpClient } from '@angular/common/Http';

@Injectable({
  providedIn: 'root'
})
export class TrainingService {
  path: string='http://localhost:4339/api/Training';

  constructor(private _client: HttpClient) { }

  public GetAll(sts:string):Observable<Training[]>
  {
    return this._client.get<Training[]>(this.path+"/GetById/"+sts);
  }
}
