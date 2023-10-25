import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Artwork } from 'src/app/database/artwork';
import { ARTWORKS } from 'src/app/database/mock-artwork-list';
import { ArtworkService } from 'src/app/services/artwork.service';

@Component({
  selector: 'app-list-artwork',
  templateUrl: './list-artwork.component.html',
})
export class ListArtworkComponent implements OnInit {
  artworkList: Artwork[] = ARTWORKS;

  constructor(
    private router: Router,
    private artworkService: ArtworkService
    ) 
  {}

  ngOnInit() {
    this.artworkList = this.artworkService.getArtworkList();
  }

    goToArtwork(artwork: Artwork) {
      this.router.navigate(['/artwork', artwork.id]);
    }
}

