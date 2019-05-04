import { Component, OnInit } from '@angular/core';
import { ICategoryModel } from '../models/category-model';
import { ActivatedRoute } from '@angular/router';
import { CategoryService } from '../shared/category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  public categoryModel: ICategoryModel;
  private _categoryService: CategoryService;
  private _route: ActivatedRoute;
  constructor(
    categoryService: CategoryService,
    route: ActivatedRoute,
  ) {
    this._categoryService = categoryService;
    this._route = route;
  }

  ngOnInit() {
    //let id = +this._route.snapshot.paramMap.get('id');
    //this.getCategoryById(id);
    this._route.params.subscribe(params => {
      let id = params['id'];
      this.getCategoryById(id); // reset and set based on new parameter this time
    });
  }
  getCategoryById(id: number): void {
    this._categoryService.getCategoryById(id).subscribe(
      (data: ICategoryModel) => {
        this.categoryModel = data;
        //$('#category:target').css("display", "block");//display: block;
      }, error => (error)
    );
  }

}
