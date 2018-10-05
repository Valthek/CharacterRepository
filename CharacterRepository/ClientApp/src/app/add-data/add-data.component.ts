import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-add-data",
  templateUrl: "./add-data.component.html"
})
export class AddDataComponent {
  public characterSheets: ICharacterSheet[];

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    // We don't need no constructor
  }

  public postData() {
    console.log("Test");
  }
}

interface ICharacterSheet {
  name: string;
  system: string;
  player: string;
}
