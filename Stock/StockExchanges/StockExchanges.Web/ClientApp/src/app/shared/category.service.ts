import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable} from 'rxjs';

@Injectable()
export class CategoryService {
  private _httpClient: HttpClient;
  private _baseUrl: string;

  constructor(
    httpClient: HttpClient, 
    @Inject('BASE_URL') baseUrl: string
    ) { 
    this._httpClient = httpClient;
    this._baseUrl = baseUrl;
  }
  getFeature(): Observable<any>{
    return this._httpClient.get(this._baseUrl + 'api/Category/GetFeatures');
  }
  getCategoryById(id: number): Observable<any> {
    return this._httpClient.get(this._baseUrl + 'api/Category/GetCategoryById?id=' + id);
  }
}
