import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-fetch-data",
  templateUrl: "./fetch-data.component.html"
})
export class FetchDataComponent {
  public characterSheets: ICharacterSheet[];

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    http.get<ICharacterSheet[]>(baseUrl + "api/CharacterData/CharacterSheets").subscribe(result => {
      this.characterSheets = result;
    }, error => console.error(error));
  }
}

interface ICharacterSheet {
  name: string;
  system: string;
  player: string;
}
