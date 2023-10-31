import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Artwork } from 'src/app/database/artwork';
import { ArtworkService } from 'src/app/services/artwork.service';

@Component({
  selector: 'app-edit-artwork',
  templateUrl: './edit-artwork.component.html',
  styleUrls: ['./edit-artwork.component.scss']
})
export class EditArtworkComponent implements OnInit {

  artwork: Artwork|undefined;

  // récupération de l'id dans la route
  // récupération du service
  constructor(
    private route: ActivatedRoute,
    private artworkService: ArtworkService
  ) { }

  ngOnInit() {
    // peut valoir null, nous insérons donc une string et non un number
    const artworkId: string|null = this.route.snapshot.paramMap.get('id');
    if(artworkId) {
      this.artwork = this.artworkService.getArtworkById(+artworkId);
    } else {
      this.artwork = undefined;
    }
  }

}
