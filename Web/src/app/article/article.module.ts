import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { ArticleItemComponent } from './article-list/article-item/article-item.component';
import { ArticleListComponent } from './article-list/article-list.component';

@NgModule({
  imports: [
    CommonModule, SharedModule
  ],
  declarations: [ArticleListComponent, ArticleItemComponent]
})
export class ArticleModule { }
