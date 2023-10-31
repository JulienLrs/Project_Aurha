import { Component } from '@angular/core';

@Component({
  selector: 'app-page-not-found',
  template: `
  <div class="center">
    <h1 class="center">Sorry</h1>
    <h3>This page does not exist !</h3>
    <a routerLink="/artworks" class="btn-floating btn-large waves-effect waves-light black" style="margin: 5%;">
        Back
    </a>
</div>
`
})
export class PageNotFoundComponent {

}
