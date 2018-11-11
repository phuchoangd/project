import { Component, OnInit } from '@angular/core';
import { PostService } from '../../app/shared/post.service'
import { IPostModel } from '../../app/models/post-model'

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  public postModel: IPostModel[];
  private _postService: PostService;
  constructor(
    postService: PostService
  ) {
      this._postService = postService;
   }

  ngOnInit() {
    this.postModel = this._postService.getAllPosts();
  }

}
