function labelMat = KNN(inx,data,labels,k)
%% 
%   inx Ϊ ����������ݣ�dataΪ�������ݣ�labelsΪ������ǩ
%%
[inxrow,~]=size(inx);
[datarow , ~] = size(data);
labelMat=zeros(inxrow,1);
for i=1:inxrow
    distanceMat=zeros(datarow,1);
    for j=1:datarow
        distance=dtw(inx(i,:),data(j,:));
        distanceMat(j)=distance;
    end
    [B , IX] = sort(distanceMat,'ascend');
    len = min(k,length(B));
    label = mode(labels(IX(1:len)));
    labelMat(i)=label;
end

end
