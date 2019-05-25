import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable} from 'rxjs';
import { ICommentModel } from '../models/comment-model';

@Injectable()
export class PostService {

  private _httpClient: HttpClient;
  private _baseUrl: string;

  constructor(
    httpClient: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    this._httpClient = httpClient;
    this._baseUrl = baseUrl;
  }
  getPostById(id: number): Observable<any> {
    return this._httpClient.get(this._baseUrl + 'api/Post/Detail?id=' + id);
  }

  getAllPosts(): Observable<any> {
    return this._httpClient.get(this._baseUrl + 'api/Post/GetAllPosts');
  }
  addComment(model: ICommentModel): Observable<any> {
    return this._httpClient.post(this._baseUrl + 'api/Comment/Add', model);
  }
}
