import { HttpClient } from '@angular/common/http';
import { Component, Injectable, Output } from '@angular/core';

@Component({
  selector: 'app-linqdictionary',
  templateUrl: './linqdictionary.component.html',
  styleUrl: './linqdictionary.component.css'
})

@Injectable({providedIn: 'root'})
export class LinqdictionaryComponent {

  constructor(private http: HttpClient) {
    // This service can now make HTTP requests via `this.http`.
  }
    
  
  doAThing =() => {
      this.http.get('https://localhost:7194/LINQDictionaryBaseModule/Test').subscribe(config => {
        // process the configuration.
        console.log(config);
    });
  }
}

