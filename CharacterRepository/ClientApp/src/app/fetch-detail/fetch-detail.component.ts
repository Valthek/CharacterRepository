import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-fetch-detail",
  templateUrl: "./fetch-detail.component.html"
})

export class FetchDataComponent {
  public characterSheets: ICharacterSheet[];

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    http.get<ICharacterSheet[]>(baseUrl + "api/CharacterData/CharacterSheet").subscribe(result => {
      console.log(result);
      this.characterSheets = result;
    }, error => console.error(error));
  }
}

interface ICharacterSheet {
  name: string;
  system: string;
  player: string;

  characterAttributeNames: string[];
  characterAttributeValues: number[];

}


