import { Component, OnInit } from '@angular/core';
import { PostService } from '../shared/post.service';
import { IPostDetailModel } from '../models/post-detail-model';
import { ActivatedRoute } from '@angular/router';
import { ICommentModel } from '../models/comment-model';

@Component({
  selector: 'app-post-detail',
  templateUrl: './post-detail.component.html',
  styleUrls: ['./post-detail.component.css']
})
export class PostDetailComponent implements OnInit {
  public postDetailModel: IPostDetailModel;
  public commentModel: ICommentModel;
  public Description: string;
  private _postService: PostService;
  private _route: ActivatedRoute;

  constructor(
    postService: PostService,
    route: ActivatedRoute,
  ) {
    this._postService = postService;
    this._route = route;
  }

  ngOnInit() {
    const id = +this._route.snapshot.paramMap.get('id');
    this.getPostById(id);
  }
  getPostById(id: number): void {
    this._postService.getPostById(id).subscribe(
      (data: IPostDetailModel) => {
        this.postDetailModel = data
      }, error => (error)
    );
  }
  addComment() {
    this.commentModel.PostId = this.postDetailModel.Id;
    this.commentModel.Description = this.Description;
    this._postService.addComment(this.commentModel).subscribe(
      (data: boolean) => {
        
      }, error => (error)
    );
  }
}
