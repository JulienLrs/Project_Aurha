import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Artwork } from 'src/app/database/artwork';
import { ArtworkService } from 'src/app/services/artwork.service';

@Component({
  selector: 'app-artwork-form',
  templateUrl: './artwork-form.component.html',
  // styleUrls: ['./artwork-form.component.css']
})
export class ArtworkFormComponent implements OnInit {

  @Input() artwork: Artwork;

   // tout mes categoriess disponibles dans l'application
   category: string[];

   constructor(
    private artworkService: ArtworkService,
    private router: Router) { }

   ngOnInit() {
    // Récupération de la liste de toutes nos oeuvres
     this.category = this.artworkService.getArtworkCategoryList();
   }
   // L'oeuvre en cours d'edition a t elle ou non la category passée en parametre
   hasCategory(categories: string): boolean {
    return this.artwork.category.includes(categories);
   }
   // Modification de prise en compte la nouvelle category cochée ou décochée
   selectCategory($event: Event, categories: string) {
    const isChecked: boolean = ($event.target as HTMLInputElement).checked;

    
    if(isChecked) {
      // Ajout d'une category a mon oeuvre
      this.artwork.category.push(categories);
    } else {
      // Retire une category de mon oeuvre
       const index = this.artwork.category.indexOf(categories);
       this.artwork.category.splice(index, 1);
    }
   }

   isCategoriesValid(categories: string): boolean {
    // longueur des types d'une category = 1
    // si la category sur laquelle je travaille n'a qu'une seule categorie et s'il sagit du type courant alors je block la checkbox 
    if(this.artwork.category.length == 1 && this.hasCategory(categories)) {
      return false;
    }
    // Permet de bloquer ou débloquer les checkbox dynamiquement en fonction d'une regle de validation métier
    // si l'utilisateur a deja selectionné 2 categories, alors il faut l'empecher de pouvoir en selectionner d'avantage
    // mais également lui laisser la possibilité de pouvoir en deselectionner
    if(this.artwork.category.length > 1 && !this.hasCategory(categories)) {
      return false;
    }

    return true;
   }
   // Soumission du form par l'utilisateur
   onSubmit() {
    console.log('Submit form !');
    // rediretion de l'utilisateur sur la page de l'oeuvre + l'identifiant de l'oeuvre courante
    this.router.navigate(['/artwork', this.artwork.id]);
   }
}
