import { Component, OnInit, Input } from '@angular/core';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
})
export class AppComponent  {
  constructor(private userService : UserService){
    let result =this.userService.getUser().subscribe((data: {}) => {
       console.log({data});
    });
   }

 
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