import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListArtworkComponent } from 'src/app/components/list-artwork/list-artwork.component';
import { DetailArtworkComponent } from 'src/app/components/detail-artwork/detail-artwork.component';
import { BorderCardDirective } from 'src/app/directives/border-card.directive';
import { HoverCardDirective } from 'src/app/directives/hover-card.directive';
import { RouterModule, Routes } from '@angular/router';
import { ArtworkService } from 'src/app/services/artwork.service';
import { FormsModule } from '@angular/forms';
import { ArtworkFormComponent } from 'src/app/components/artwork-form/artwork-form.component';
import { EditArtworkComponent } from 'src/app/components/edit-artwork/edit-artwork.component';

const artworkroutes: Routes = [
    { path: 'edit/artwork/:id', component:  EditArtworkComponent},
    { path: 'artworks', component:  ListArtworkComponent},
    { path: 'artwork/:id', component:  DetailArtworkComponent},
];

@NgModule({
  declarations: [
    ListArtworkComponent,
    DetailArtworkComponent,
    ArtworkFormComponent,
    EditArtworkComponent,
    BorderCardDirective,
    HoverCardDirective
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild(artworkroutes) // mise en places des routes propre aux artworks
  ],
  // Injection d'un service au niveau d'un module et plus au niveau d'un module racine
  providers: [
    ArtworkService
  ]
})

export class ArtworkModule { }
