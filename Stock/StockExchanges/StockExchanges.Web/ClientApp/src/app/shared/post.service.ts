import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPostModel } from '../../app/models/post-model'

@Injectable()
export class PostService {
  public postModel: IPostModel[];

  private _httpClient: HttpClient;
  private _baseUrl: string;

  constructor(
    httpClient: HttpClient, 
    @Inject('BASE_URL') baseUrl: string
    ) { 
    this._httpClient = httpClient;
    this._baseUrl = baseUrl;
  }
    public getAllPosts(){
      this._httpClient.get(this._baseUrl + 'GetAllPosts').subscribe(
        (data: IPostModel[]) => {
          this.postModel = data
        },error => (error)
      );
      return this.postModel;
    }
}
