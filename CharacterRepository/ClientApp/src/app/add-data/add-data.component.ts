import { Component, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { extend } from "webdriver-js-extender";

@Component({
  selector: "app-add-data",
  templateUrl: "./add-data.component.html"
})
export class AddDataComponent {  
  public characterSheet: InfinityCharacterSheet = new InfinityCharacterSheet("steve", "EP", "Valthek");
  public http: HttpClient;

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    // We don't need no constructor
    this.http = http;
  }

  public postData(@Inject("BASE_URL") baseUrl: string) {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application / json'
      })
    }
    this.http.post<ICharacterSheet>(baseUrl + "api/CharacterData/CharacterSheets", this.characterSheet, httpOptions).subscribe(result => {
      console.log(this.characterSheet);
    }, error => console.error(error));
  }
}

export class InfinityCharacterSheet implements ICharacterSheet {
  name: string;
  system: string;
  player: string;

  constructor(name: string, system: string, player: string) {
    this.name = name;
    this.system = system;
    this.player = player;
  }
}

interface ICharacterSheet {
  name: string;
  system: string;
  player: string;
}
