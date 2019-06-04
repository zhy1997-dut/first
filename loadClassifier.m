function classifier=loadClassifier(path)

classifier=cell2mat(struct2cell(load(path)));