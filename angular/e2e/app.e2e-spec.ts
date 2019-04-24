import { SmartLibrariesTemplatePage } from './app.po';

describe('SmartLibraries App', function() {
  let page: SmartLibrariesTemplatePage;

  beforeEach(() => {
    page = new SmartLibrariesTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
