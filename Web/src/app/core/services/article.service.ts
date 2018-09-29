import { Injectable } from '@angular/core';
import { HttpParams } from '@angular/common/http';

import { Article } from '../models/article';
import { ApiService } from './api.service';

@Injectable()
export class ArticleService {

    private url = '/api/article';

    constructor(private _apiService: ApiService) {

    }

    get(): Promise<Article[]> {
        return this._apiService.get<Article[]>(this.url);
    }

    getById(id: number): Promise<Article> {
        const params = new HttpParams().set('id', id.toString());

        return this._apiService.get<Article>(this.url, params);
    }

    create(article: Article): Promise<Article> {
        return this._apiService.post<Article>(this.url, article);
    }

    update(article: Article): Promise<Article> {
        return this._apiService.put<Article>(this.url, article);
    }
}
