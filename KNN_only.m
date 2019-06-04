function labelMat = KNN_only(inx,data,labels,k)
%% 
%   inx Ϊ ����������ݣ�dataΪ�������ݣ�labelsΪ������ǩ
%%
[inxrow,~]=size(inx);
[datarow,~] = size(data);
labelMat=zeros(inxrow,1);
for i=1:inxrow
    diffMat = repmat(inx(i,:),[datarow,1]) - data ;
    distanceMat = sqrt(sum(diffMat.^2,2));
    [B , IX] = sort(distanceMat,'ascend');
    len = min(k,length(B));
    relustLabel = mode(labels(IX(1:len)));
    labelMat(i)=relustLabel;
end
end