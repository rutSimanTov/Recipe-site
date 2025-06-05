import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'minute'
})
export class MinutePipe implements PipeTransform {

  transform(value: number): string {
    if (value == 1)
      return "" + value + " minute"
    else
      return "" + value + " minutes";
  }

}
