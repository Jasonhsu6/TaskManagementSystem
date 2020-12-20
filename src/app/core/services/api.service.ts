import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(protected http: HttpClient) {  }

  getAll(path: string): Observable<any[]> {
    return this.http.get(`${environment.apiUrl}${path}`).pipe(
      map((response) => response as any[])
    );
  }

  getOne(path: string, id?: number): Observable<any> {
    let getUrl: string;
    if (id) {
      getUrl = `${environment.apiUrl}${path}` + '/' + id;
    } else {
      getUrl = `${environment.apiUrl}${path}` + '/';
    }
    return this.http.get(getUrl).pipe(
      map((response) => response as any)
    );
  }

  addOne(path: string, obj: any): Observable<any> {
    return this.http.post<any>(`${environment.apiUrl}${path}`, obj).pipe(
      map((response) => response as any)
    );
  }

  updateOne(path: string, obj: any): Observable<any>{
    return this.http.put<any>(`${environment.apiUrl}${path}`, obj).pipe(
      map((response) => response as any)
    );
  }

  deleteOne(path: string, obj: any): Observable<any>{
    return this.http.delete<any>(`${environment.apiUrl}${path}`, obj).pipe(
      map((response) => response as any)
    );
  }

}
