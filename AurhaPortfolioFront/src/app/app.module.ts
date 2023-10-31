import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './components/app.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { ArtworkModule } from './modules/artwork/artwork.module';
import { UserService } from './services/user.service';

@NgModule({
  declarations: [
    AppComponent,
    PageNotFoundComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
