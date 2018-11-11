import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SignUpComponent } from './sign-up/sign-up.component';

import { UserService } from './shared/user.service';
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
import { PostService } from './shared/post.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
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
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      //UI
      { path: 'sign-up', component: SignUpComponent },
      { path: 'sign-in', component: SignInComponent },
      { path: 'post-detail/:id', component: PostDetailComponent },
      { path: 'category/:id', component:  CategoryComponent }
    ])
  ],
  providers: [UserService, PostService],
  bootstrap: [AppComponent]
})
export class AppModule { }
