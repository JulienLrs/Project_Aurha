export class Artwork {
    id: number;
    name: string;
    description: string;
    price: number;
    picture: string;
    category: Array<string>;
    created: Date;

    constructor(
        name: string = 'Entrez un nom...',
        description: string = 'future description',
        price: number = 100,
        picture: string = 'https://img.pokemondb.net/sprites/scarlet-violet/normal/iron-leaves.png',
        category: string[] = ['Normal'],
        created: Date = new Date()
    ) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.picture = picture;
        this.category = category;
        this.created = created;
    }
}