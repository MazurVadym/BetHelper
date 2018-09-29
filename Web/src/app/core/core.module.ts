import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { ApiService } from './services/api.service';
import { ArticleService } from './services/article.service';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [
    ApiService,
    ArticleService
  ],
  declarations: []
})
export class CoreModule { }
