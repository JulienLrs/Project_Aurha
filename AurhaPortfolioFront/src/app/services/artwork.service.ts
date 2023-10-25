import { Injectable } from '@angular/core';
import { Artwork } from '../database/artwork';
import { ARTWORKS } from '../database/mock-artwork-list';

@Injectable()

export class ArtworkService {
  // Encapsule ma liste artwork dans un service qui profite du systeme d'injection de dépendance
  getArtworkList(): Artwork[] {
    return ARTWORKS;
  }
  // Méthode qui renvoie une oeuvre
  getArtworkById(artworkId: number): Artwork|undefined {
    return ARTWORKS.find(artwork => artwork.id == artworkId);
  }

  getArtworkCategoryList(): string[] {
    // @Todo dans le futur, aller chercher les différentes catégorie avec de l'algo.
    return ['Calligraphy', 'Paint', 'Other'];
  }
}
