import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, UrlHandlingStrategy } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { FooterComponent } from './footer/footer.component';
import { ContactComponent } from './contact/contact.component';
import { PostComponent } from './post/post.component';
import { NewsComponent } from './news/news.component';
import { NavigationComponent } from './navigation/navigation.component';
import { IntroComponent } from './intro/intro.component';
import { FeatureComponent } from './feature/feature.component';
import { PostDetailComponent } from './post-detail/post-detail.component';
import { CategoryComponent } from './category/category.component';

import { UserService } from './shared/user.service';
import { PostService } from './shared/post.service';
import { CategoryService } from './shared/category.service'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    SignUpComponent,
    SignInComponent,
    FooterComponent,
    ContactComponent,
    PostComponent,
    NewsComponent,
    NavigationComponent,
    IntroComponent,
    FeatureComponent,
    PostDetailComponent,
    CategoryComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: PostComponent, pathMatch: 'full' },
      //UI
      { path: 'sign-up', component: SignUpComponent },
      { path: 'sign-in', component: SignInComponent },
      { path: 'post-detail/:id', component: PostDetailComponent },
      { path: 'category/:id', component: CategoryComponent }
    ])
  ],
  providers: [UserService, PostService, CategoryService, { provide: 'BASE_URL', useFactory: getBaseUrl }],
  bootstrap: [AppComponent]
})
export class AppModule { }

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}
