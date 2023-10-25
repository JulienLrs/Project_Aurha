import { Component } from '@angular/core';

@Component({
  selector: 'app-page-not-found',
  template: `
  <div class="center">
    <h1></h1>
    <img height="300" width="300" src="https://media.istockphoto.com/id/1220137067/vector/sorry-calligraphy-word-with-grunge-speech-bubble-apologise-vector-phrase.jpg?s=170667a&w=0&k=20&c=GHLd5hrIZM2ttgybLKL5AwXxpzziat92NZm4axWUaH0="/>
    <h1>This page does not exist !</h1>
    <a routerLink="/artworks" class="btn-floating btn-large waves-effect waves-light black p-10">
        Back home
    </a>
</div>
`
})
export class PageNotFoundComponent {

}
