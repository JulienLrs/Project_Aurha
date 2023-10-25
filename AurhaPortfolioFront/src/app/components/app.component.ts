import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
})
export class AppComponent {
  // artworkList: Artwork[] = ARTWORKS;
  // artworkSelected: Artwork|undefined;

  // ngOnInit() {
  //   console.table (this.artworkList);
  // }

  // selectArtwork(artworkId: string) {
  //   const artwork: Artwork|undefined = this.artworkList.find(artwork => artwork.id == +artworkId);
  //   if(artwork) {
  //     console.log(`Vous avez choisi l'oeuvre ${artwork.name}`);
  //     this.artworkSelected = artwork;
  //   }
  //   else {
  //     console.log(`Vous avez demandé une oeuvre qui n'existe pas.`);
  //     this.artworkSelected = artwork;
  //   }
  // }
}