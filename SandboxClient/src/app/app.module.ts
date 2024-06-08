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
import { MatButton, MatButtonModule } from '@angular/material/button';
import { LinqdictionaryComponent } from './linqdictionary/linqdictionary.component';
import { TestComponent } from './test/test.component';
import { AppComponentNavComponent } from './app-component-nav/app-component-nav.component';
import { provideHttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LinqdictionaryComponent,
    TestComponent,
    AppComponentNavComponent
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
    MatButton,
    MatButtonModule,
    RouterModule,
    AppRoutingModule
  ],
  providers: [
    provideAnimationsAsync(),
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
