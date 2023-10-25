import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[artworkBorderCard]'
})
export class BorderCardDirective {
    private initialColor: string = "#f5f5f5";
    private defaultColor: string = '#009688';
    private defaultHeight: number = 100;

  constructor(private element: ElementRef) {
    this.setBorder(this.initialColor);
    //this.setHeight(this.defaultHeight);
   }

   @Input ('pokemonBorderCard') borderColor: string; // alias
   @Input () artworkBorderCard: string;


   @HostListener('mouseenter') onMouseEnter() {
    this.setBorder(this.borderColor || this.defaultColor);
   }

   @HostListener('mouseleave') onMouseLeave() {
    this.setBorder(this.initialColor);
   }

   private setBorder(color: string) {
    let border = 'solid 2px ' + color;
    this.element.nativeElement.style.border = border;
   }

   private setHeight(height: number) {
    this.element.nativeElement.style.height = height + 'px'
   }
}
