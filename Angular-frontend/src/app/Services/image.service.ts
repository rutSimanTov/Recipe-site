import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ImageService {

  constructor(private httpC: HttpClient) { }

  onUpload(image: File): Observable<any> {
    const fromData = new FormData()
    fromData.append('file', image, image.name);
    return this.httpC.post('https://localhost:7054/image/upload', fromData)
  }
}
