import {WordsService} from "~/scripts/wordsService";

export class AvailableWordService {

  static ValidWords(typed: string) {
    const wordList = WordsService.getWords()
    const options = wordList.filter(word => {
      for (let i = 0; i < word.length; i++) {
        if (typed[i] === '?') {
          continue
        }
        if (typed[i] !== word[i]) {
          return false
        }
      }
      return true
    })
    console.log(options)
    return options
  }
}