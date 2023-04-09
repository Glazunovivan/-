
import { Time } from "@angular/common";
import { Guid } from "guid-typescript";

export interface IStore {
    id: Guid,
    name: string,
    description: string,
    datestart: Time,
    dateend: Time
}