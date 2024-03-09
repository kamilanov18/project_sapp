import rs from '../i-18.json';

type TranslatableFile = {
    [language: string]: {
        [page: string]: {
            [key:string]: string
        }
    };
}

export class TranslatorService {

    private _language: string = "bg";
    private _source: TranslatableFile;
    constructor(language: string='') {
        this._language = language == '' ? this._language : language;
        this._source = rs as TranslatableFile;
    }

    public get(key: string,language: string = this._language): string {
        try {
            const keys=key.split('.');
            return this._source[language][keys[0]][keys[1]];
        } catch {
            return key;
        }
    }
}