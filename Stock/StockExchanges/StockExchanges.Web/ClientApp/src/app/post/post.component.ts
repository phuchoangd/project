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
    commentService: PostService
  ) {
      this._postService = commentService;
   }

  ngOnInit() {
    this.getPosts();
    
  }
  getPosts(): void {
    this._postService.getAllPosts().subscribe(
      (data: IPostModel[]) => {
        this.postModel = data
      },error => (error)
    );
  }
}
