import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import {RouterModule, Routes} from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import {MatToolbarModule} from '@angular/material/toolbar';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTabsModule, MatTabNav, MatTabNavPanel} from '@angular/material/tabs';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    MatSlideToggleModule,
    MatToolbarModule,
    MatSidenavModule,
    MatButtonModule,
    MatTabsModule,
    MatTabNav,
    MatTabNavPanel,
    MatListModule,
    MatIconModule,
    RouterModule,
    AppRoutingModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
