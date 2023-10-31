import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Artwork } from 'src/app/database/artwork';
import { ArtworkService } from 'src/app/services/artwork.service';

@Component({
  selector: 'app-detail-artwork',
  templateUrl: './detail-artwork.component.html'
})

export class DetailArtworkComponent implements OnInit{

  artworkList: Artwork[];
  artwork: Artwork|undefined; // Contient une oeuvre à afficher - Typage avec undefined >> oeuvre non trouvée
  
  constructor(
    private route: ActivatedRoute, 
    private router: Router,
    private artworkService: ArtworkService,
    ) { }

  ngOnInit() {
    // Récupération de l'id contenu dans l'URL
    const artworkId: string|null = this.route.snapshot.paramMap.get('id');

    if (artworkId) {
      // si mon id à bien été trouvé dans l'URL, attribution à la propriété artwork de cet identifiant
      this.artwork = this.artworkService.getArtworkById(+artworkId);
    }
  }

  goToArtworkList() {
    this.router.navigate(['/artworks']);
  }

  goToEditArtwotk(artwork: Artwork) {
    this.router.navigate(['/edit/artwork', artwork.id]);
  }
}
