import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Artwork } from 'src/app/database/artwork';
import { ArtworkService } from 'src/app/services/artwork.service';

@Component({
  selector: 'app-artwork-form',
  templateUrl: './artwork-form.component.html',
})
export class ArtworkFormComponent implements OnInit {
  @Input() artwork: Artwork;
   category: string[];

   constructor(
    private artworkService: ArtworkService,
    private router: Router) { }

   ngOnInit() {
     this.category = this.artworkService.getArtworkCategoryList();
   }

   hasCategory(categories: string): boolean {
    return this.artwork.category.includes(categories);
   }

   selectCategory($event: Event, categories: string) {
    const isChecked: boolean = ($event.target as HTMLInputElement).checked;

    
    if(isChecked) {
      // Ajout d'une category
      this.artwork.category.push(categories);
    } else {
      // Retire une category
       const index = this.artwork.category.indexOf(categories);
       this.artwork.category.splice(index, 1);
    }
   }

   onSubmit() {
    console.log('Submit form !');
    this.router.navigate(['/artwork', this.artwork.id]);
   }
}
