import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../../app/shared/category.service'
import { IFeatureModel } from '../../app/models/feature-model'

@Component({
  selector: 'app-feature',
  templateUrl: './feature.component.html',
  styleUrls: ['./feature.component.css']
})
export class FeatureComponent implements OnInit {
  public featureModels: IFeatureModel[];
  private _categoryService: CategoryService;

  constructor(categoryService: CategoryService) {
      this._categoryService = categoryService;
   }

  ngOnInit() {
    this.getFeature();
  }
  getFeature():void{
    this._categoryService.getFeature().subscribe(
      (data: IFeatureModel[]) => {
        this.featureModels = data
      },error => (error)
    );
  }
}
